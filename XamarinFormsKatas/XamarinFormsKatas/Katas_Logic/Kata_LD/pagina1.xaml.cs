﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina1 : ContentView
    {
        public pagina1(string texto)
        {
            InitializeComponent();
            string t = texto;
            BindingContext = new pagina1_VM(t);
        }
    }
}