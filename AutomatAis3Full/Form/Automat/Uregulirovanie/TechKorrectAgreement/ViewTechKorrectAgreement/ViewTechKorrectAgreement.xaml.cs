﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutomatAis3Full.Form.Automat.Uregulirovanie.TechKorrectAgreement.ViewTechKorrectAgreement
{
    /// <summary>
    /// Логика взаимодействия для ViewTechKorrectAgreement.xaml
    /// </summary>
    public partial class ViewTechKorrectAgreement : UserControl
    {
        public ViewTechKorrectAgreement()
        {
            InitializeComponent();
            DataContext = new DataContextTechKorrectAgreement.DataContextTechKorrectAgreement();
        }
    }
}
