using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace UWP_manual
{
    /// <summary>
    /// Главная страница
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Introduction intro = new Introduction();
        Binding_con bc = new Binding_con();
        Basics basics = new Basics();
        Сomposition_Layouts cl = new Сomposition_Layouts();
        Element_Controls ec = new Element_Controls();
        ResPage res = new ResPage();

        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            myFrame.Navigate(typeof(Introduction));
            textHeader.Text = intro.txtHeader;
        }

        //обработчик раскрытия гамбургер-меню
        private void gamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        //кнопка "Главная"
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Introduction));
            textHeader.Text = intro.txtHeader;
        }

        //кнопка "Выход"
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        //Выбор главы
        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (introductionItem.IsSelected)
            {
                myFrame.Navigate(typeof(Introduction));
                textHeader.Text = intro.txtHeader;
            }

            if (basicsItem.IsSelected)
            {
                myFrame.Navigate(typeof(Basics));
                textHeader.Text = basics.txtHeader;
            }

            if (compositionItem.IsSelected)
            {
                myFrame.Navigate(typeof(Сomposition_Layouts));
                textHeader.Text = cl.txtHeader;
            }

            if (controlsItem.IsSelected)
            {
                myFrame.Navigate(typeof(Element_Controls));
                textHeader.Text = ec.txtHeader;
            }

            if (bindingItem.IsSelected)
            {
                myFrame.Navigate(typeof(Binding_con));
                textHeader.Text = bc.txtHeader;
            }

            if (resourcesItem.IsSelected)
            {
                myFrame.Navigate(typeof(ResPage));
                textHeader.Text = res.txtHeader;
            }
        }

        //кнопка "Назад" в нижнем меню
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.CanGoBack)
            {
                myFrame.GoBack();
            }
        }

        //кнопка "Вперёд" в нижнем меню
        private void forwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.CanGoForward)
            {
                myFrame.GoForward();
            }
        }

        //кнопка "Домой" в нижнем меню
        private void homeBottomButton_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Introduction));
            textHeader.Text = intro.txtHeader;
        }
    }
}
