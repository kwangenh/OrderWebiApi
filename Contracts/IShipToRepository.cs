using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IShipToRepository
    {
        public List<ShipTo> GetShipTos();
        public ShipTo GetShipTo(int shipToId);
        public ShipTo CreateShipTo(ShipTo thisShipTo);
        public ShipTo DeleteShipTo(int shipToId);
        public ShipTo EditShipTo(ShipTo thisShipTo);
    }
}
