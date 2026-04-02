
using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public interface IBillService
    {
        Task AddBillAsync(Bill bill);
        Task<List<Bill>> GetAllBillsAsync();
        string GenerateNextInvoiceNumber();
    }
}