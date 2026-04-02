using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public class BillService : IBillService
    {
        private readonly List<Bill> _bills = new();
        private int _nextId = 1;
        private int _invoiceSeed = 1001;

        public Task AddBillAsync(Bill bill)
        {
            bill.Id = _nextId++;

            if (string.IsNullOrWhiteSpace(bill.InvoiceNumber))
            {
                bill.InvoiceNumber = GenerateNextInvoiceNumber();
            }

            _bills.Add(bill);
            return Task.CompletedTask;
        }

        public Task<List<Bill>> GetAllBillsAsync()
        {
            return Task.FromResult(_bills.ToList());
        }

        public string GenerateNextInvoiceNumber()
        {
            return $"INV-{_invoiceSeed++}";
        }
    }
}