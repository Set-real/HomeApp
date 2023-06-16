﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridPage : ContentPage
	{
        public GridPage()
        {
            Grid grid = new Grid
            {
                // Набор строк 
                RowDefinitions =
               {
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
               },

                // Набор столбцов
                ColumnDefinitions =
               {
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
               }
            };

            //PopulateGrid(grid);
            MergeColumns(grid);

            Content = grid;
        }
        /// <summary>
        ///  Заполнение лейаута
        /// </summary>
        public void PopulateGrid(Grid grid)
        {
            // Добавление элементов по определенным позициям
            grid.Children.Add(new BoxView { Color = Color.FromRgb(250, 253, 255) }, 0 /* Позиция слева */, 0 /* Позиция сверху */);

            // Сохраняем элемент перед добавлением, чтобы потом модифицировать
            var mergedRow = new BoxView { Color = Color.FromRgb(196, 232, 255) };
            // Добавляем в Grid
            grid.Children.Add(mergedRow, 0, 1);
            // Устанавливаем свойство ColumnSpan, чтобы расширить элемент на 3 позиции
            Grid.SetColumnSpan(mergedRow, 3);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(133, 207, 255) }, 0, 2);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(87, 189, 255) }, 1, 0);
            // grid.Children.Add(new BoxView { Color = Color.FromRgb(43, 172, 255) }, 1, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(23, 164, 255) }, 1, 2);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 121, 199) }, 2, 0);
            // grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 76, 199) }, 2, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 76, 199) }, 2, 2);
        }
        public void MergeColumns(Grid grid)
        {
           
            var leftBox = new BoxView { Color = Color.FromRgb(196, 232, 255) };
            grid.Children.Add(leftBox, 0, 0);
            Grid.SetRowSpan(leftBox, 3);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(133, 207, 255) }, 1, 0);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(133, 207, 255) }, 1, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(133, 207, 255) }, 1, 2);

            var rightBox = new BoxView { Color = Color.FromRgb(196, 232, 255) };
            grid.Children.Add(rightBox, 2, 0);
            Grid.SetRowSpan(rightBox, 3);
        }
    }
}