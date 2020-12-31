using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Chart_Sample
{
    public class DataViewModel
    {
        public DataViewModel()
        {
            Models = new ObservableCollection<Model>();

            Models.Add(new Model(new DateTime(2000, 1, 1), 175, -125));
            Models.Add(new Model(new DateTime(2001, 1, 1), 190, -125));
            Models.Add(new Model(new DateTime(2002, 1, 1), 210, -150));
            Models.Add(new Model(new DateTime(2003, 1, 1), 210, -200));
            Models.Add(new Model(new DateTime(2004, 1, 1), 260, -220));
            Models.Add(new Model(new DateTime(2005, 1, 1), 250, -140));
            Models.Add(new Model(new DateTime(2006, 1, 1), 220, -210));
            Models.Add(new Model(new DateTime(2007, 1, 1), 240, -290));
            Models.Add(new Model(new DateTime(2008, 1, 1), 375, -320));
            Models.Add(new Model(new DateTime(2009, 1, 1), 180, -325));
        }

        public ObservableCollection<Model> Models { get; set; }
    }
}
