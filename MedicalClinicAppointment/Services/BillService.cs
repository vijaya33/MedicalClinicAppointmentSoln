
using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public class BillService : IBillService
    {
        private readonly List<Bill> _bills = new();
        private int _nextId = 1;

        public Task AddBillAsync(Bill bill)
        {
            bill.Id = _nextId++;
            _bills.Add(bill);
            return Task.CompletedTask;
        }

        public Task<List<Bill>> GetAllBillsAsync()
        {
            return Task.FromResult(_bills.ToList());
        }
    }
}