using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDrivingSchool.WinUI.Payment
{
    public partial class frmAddPayment : Form
    {
        private int? _id = null;
        PaymentInsertRequest request = new PaymentInsertRequest();
        APIService _apiService = new APIService("Payments");
        APIService _candidates = new APIService("Candidates");
        public frmAddPayment(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var idObj = cmbCandidate.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int CandidateId))
            {
                request.UserId = CandidateId;
            }
            request.Type = txtType.Text;
            request.Amount = float.Parse(txtAmount.Text);
            request.DateOfPayment = dtpDateOfPayment.Value;
            if (_id.HasValue)
            {
                await _apiService.Update<Model.Payment>(_id, request);
            }
            else
            {
                await _apiService.Insert<Model.Payment>(request);
            }
        }

        private async void FrmAddPayment_Load(object sender, EventArgs e)
        {
            await LoadKandidati();
        }
        private async Task LoadKandidati()
        {
            var result = await _candidates.GetAll<List<Model.Candidate>>(null);
            result.Insert(0, new Model.Candidate());
            cmbCandidate.DisplayMember = "FirstName";
            cmbCandidate.ValueMember = "Id";
            cmbCandidate.DataSource = result;
        }
    }
}
