using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Services
{
    public class ShipmentContext
    {
        ProjectEntities _context;
        public ShipmentContext()
        {
            _context = new ProjectEntities();
        }


        public IEnumerable<Shipment> Get()
        {
            return _context.Shipments.ToList();
        }
        public void add(Shipment ship)
        {
            _context.Shipments.Add(ship);
            _context.SaveChanges();
        }
        public Shipment Get_ID_Details(int id)
        {
            var record = _context.Shipments.Find(id);
            return record;
        }

        public Shipment Update(int id, Shipment entity)
        {
            var record = _context.Shipments.Find(id);
            record = entity;
            _context.SaveChanges();
            return record;
        }

        public void Delete_Company_BY_ID(int id)
        {
            var record = _context.Shipments.ToList();

            foreach (var iteration in record)
            {
                if (iteration.Company_ID == id)
                {
                    _context.Shipments.Remove(iteration);
                    _context.SaveChanges();
                    return;
                }
            }
        }

    }
}