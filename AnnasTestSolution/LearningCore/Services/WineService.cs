using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Learning.Core.Domain;

namespace Learning.Core.Services
{
    public class WineService : IWineService
    {
        private IEnumerable<WineUnit> _wineList;
        public WineService()
        {
            WineListInit();
        }

        public IEnumerable<WineUnit> GetWineList()
        {
            return _wineList;
        }

        public void WineListInit()
        {
            _wineList = new[]
                            {
                                new WineUnit("Chateau Margaux", 2005, "Jean Michelle", "Bordeaux", "Cabernet Saugvignon", "Frankrike"),
                                new WineUnit("Chateau Margaux", 2000, "Jean Michelle", "Bordeaux", "Cabernet Saugvignon", "Frankrike"),
                                new WineUnit("St Esteph First Wine", 2005, "Jean Michelle", "Bordeaux", "Cabernet Saugvignon", "Frankrike"),
                                new WineUnit("St Esteph First Wine", 2000, "Jean Michelle", "Bordeaux", "Cabernet Saugvignon", "Frankrike"),
                                new WineUnit("St Emile", 2003, "Jean Jean", "Bordeaux", "Merlot", "Frankrike"),
                                new WineUnit("St Emile", 2004, "Jean Jean", "Bordeaux", "Merlot", "Frankrike"),
                                new WineUnit("St Emile", 2005, "Jean Jean", "Bordeaux", "Merlot", "Frankrike"),
                                new WineUnit("St Emile", 2000, "Jean Jean", "Bordeaux", "Merlot", "Frankrike"),
                                new WineUnit("St Emile Second wine", 2000, "Jean Jean", "Bordeaux", "Cabernet Franc", "Frankrike"),
                                new WineUnit("O la la", 1997, "Massi", "Chianti", "Sangiovese", "Italien"),
                                new WineUnit("O la la", 2000, "Massi", "Chianti", "Sangiovese", "Italien"),
                                new WineUnit("O la la", 2003, "Massi", "Chianti", "Sangiovese", "Italien"),
                                new WineUnit("O la la", 1997, "Don Giovanni", "Ghemme", "Nebbiolo", "Italien"),
                                new WineUnit("O la la", 2000, "Don Giovanni", "Ghemme", "Nebbiolo", "Italien"),
                                new WineUnit("O la la", 2001, "Don Giovanni", "Ghemme", "Nebbiolo", "Italien"),
                                new WineUnit("O la la", 2003, "Don Giovanni", "Ghemme", "Nebbiolo", "Italien")
                            };
            throw new NotImplementedException();
        }
    }
}
