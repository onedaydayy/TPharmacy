using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using TPharmacy.Shared.Domain;

namespace TPharmacy.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<OrderItem> OrderItems { get; }
        IGenericRepository<Consultation> Consultations { get; }
        IGenericRepository<Prescription> Prescriptions { get; }
    }
}