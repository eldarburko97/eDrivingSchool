﻿using eDrivingSchool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentsPage : ContentPage
    {
        public IList<Payment> datagrids { get; set; }
        public PaymentsPage()
        {
            InitializeComponent();
            /*
            datagrids = new List<Payment>();
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            datagrids.Add(new Payment() { Id = 1, Type = "Školarina", Amount = 900, DateOfPayment = "10/21/2020" });
            BindingContext = this;*/
        }
    }
}