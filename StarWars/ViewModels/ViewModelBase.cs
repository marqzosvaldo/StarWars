﻿using MvvmHelpers;
using Xamarin.Forms;

namespace StarWars.ViewModels {
    public class ViewModelBase : BaseViewModel {
        protected Page page;

        public ViewModelBase(Page page) {
            this.page = page;
        }


    }
}
