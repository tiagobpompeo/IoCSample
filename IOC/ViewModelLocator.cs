using System;
using CommonServiceLocator;
using Xamarin.Forms.Internals;

namespace IOC
{
    [Preserve(AllMembers = true)]
    public class ViewModelLocator
    {
        public ProductsViewModel ProductsViewModel
        {
            get { return ServiceLocator.Current.GetInstance<ProductsViewModel>(); }
        }
    }
}
