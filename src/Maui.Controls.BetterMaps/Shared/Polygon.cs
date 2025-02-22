﻿using System.Collections.ObjectModel;

namespace Maui.Controls.BetterMaps
{
    public class Polygon : MapElement
    {
        public static readonly BindableProperty FillColorProperty = BindableProperty.Create(
            nameof(FillColor),
            typeof(Color),
            typeof(Polygon),
            default(Color));

        public Color FillColor
        {
            get => (Color)GetValue(FillColorProperty);
            set => SetValue(FillColorProperty, value);
        }

        public IList<Position> Geopath { get; }

        public Polygon()
        {
            var observable = new ObservableCollection<Position>();
            observable.CollectionChanged += (sender, args) => OnPropertyChanged(nameof(Geopath));
            Geopath = observable;
        }
    }
}