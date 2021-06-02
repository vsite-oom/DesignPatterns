using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    interface IShipwright
    {
        Fleet CreateFleet();
    }

    class BeginnerShipwright : IShipwright
    {
        public Fleet CreateFleet()
        {
            throw new NotImplementedException();
        }
    }

    class AdvancedShipwright : IShipwright
    {
        public Fleet CreateFleet()
        {
            throw new NotImplementedException();
        }
    }

    interface IGunnery
    {
    }

    class BeginnerGunnery : IGunnery
    { }

    class AdvancedGunnery : IGunnery
    { }

    interface IGameItemFactory
    {
        IShipwright CreateShipwright();
        IGunnery CreateGunnery();
    }

    class BeginersItemFactory : IGameItemFactory
    {
        public IGunnery CreateGunnery()
        {
            throw new NotImplementedException();
        }

        public IShipwright CreateShipwright()
        {
            throw new NotImplementedException();
        }
    }

    class ProfessionalsItemFactory : IGameItemFactory
    {
        public IGunnery CreateGunnery()
        {
            throw new NotImplementedException();
        }

        public IShipwright CreateShipwright()
        {
            throw new NotImplementedException();
        }
    }

    class Fleet { }

class Game
{
    public Game(IGameItemFactory gameItemFactory)
    {
        this.gameItemFactory = gameItemFactory;
    }

    private IGameItemFactory gameItemFactory;

    private Fleet CreateFleet()
    {
        var shipwright = gameItemFactory.CreateShipwright();
        return shipwright.CreateFleet();
    }

    private void StartShooting()
    {
        var gunnery = gameItemFactory.CreateGunnery();
        // ...
    }
}
}
