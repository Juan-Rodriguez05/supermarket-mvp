using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBindingSource(productBindingSource);

            loadAllProductList();

            this.view.Show();
        }
        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductStock = "0";
            view.ProductPrice = "0";
            view.ProviderId = "0";
            view.CategoryName = "";
        }

        private void loadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.Product_Id = Convert.ToInt32(view.ProductId);
            product.Product_Name = view.ProductName;
            product.Product_Price = view.ProductPrice;
            product.Product_Stock = view.ProductStock;
            product.Provider_Id = view.ProviderId;
            product.Category_Name = view.CategoryName;


            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    //se llama al metodo add del repositorio
                    repository.edit(product);
                    view.Message = "Product added successfully";
                }
                else
                {
                    //se llama al metodo edit del repositorio
                    repository.add(product);
                    view.Message = "Product edited successfully";
                }
                view.IsSuccessful = true;
                loadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.Message = ex.Message;
                view.IsSuccessful = false;
            }
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                //se recupera el objeto de la fila seleccionada de dataviewgrid
                var product = (ProductModel)productBindingSource.Current;

                //se llama al metodo delete del repositorio
                repository.delete(product.Product_Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                loadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            //se consigue el objeto del datagridview que se encuentra seleccionado
            var product = (ProductModel)productBindingSource.Current;

            //se cambia el contenido de las cajas de texto
            //del datagridview

            view.ProductId = product.Product_Id.ToString();
            view.ProductName = product.Product_Name;
            view.ProductPrice = product.Product_Price.ToString();
            view.ProductStock = product.Product_Stock.ToString();
            view.ProviderId = product.Provider_Id.ToString();
            view.CategoryName = product.Category_Name;

            //se establece el modo de edicion
            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false) 
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}
