using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
   public class PaymentsViewModel : BaseViewModel
    {
        private readonly APIService _paymentService = new APIService("Payments");
        public CandidateSearchRequest search_request = new CandidateSearchRequest();
        private readonly APIService _candidateService = new APIService("Candidates");
        public PaymentSearchRequest search_request2 = new PaymentSearchRequest();
        private readonly APIService categoryService = new APIService("Categories");

        public ObservableCollection<Payment> PaymentsList { get; set; } = new ObservableCollection<Payment>();


        float _total = 0.00f;
        public float Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        }

        public async Task Init()
        {
            if(PaymentsList.Count > 0)
            {
                PaymentsList.Clear();
                Total = 0.00f;
            }
            search_request.Username = APIService.Username;
            var candidates = await _candidateService.GetAll<List<Candidate>>(search_request);
            var candidate = candidates[0];
            search_request2.CandidateId = candidate.Id;
            var payments = await _paymentService.GetAll<List<Payment>>(search_request2);
            foreach (var payment in payments)
            {
                var category = await categoryService.GetById<Category>(payment.CategoryId);
                payment.Category = category.Name;
                PaymentsList.Add(payment);
                Total += payment.Amount;
            }
        }
    }
}
