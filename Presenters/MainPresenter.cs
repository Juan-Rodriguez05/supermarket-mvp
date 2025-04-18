﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainview;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainview, string sqlConnectionString)
        {
            this.mainview = mainview;
            this.sqlConnectionString = sqlConnectionString;

            this.mainview.ShowProductView += ShowProductView;
            this.mainview.ShowPayModeView += ShowPayModeView;
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainview);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }

        private void ShowPayModeView(object sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainview);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }


    }
}
