﻿using eDrivingSchool.Model;
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

namespace eDrivingSchool.WinUI.CertificateRequests
{
    public partial class frmUpdateCertificateRequest : Form
    {
        private APIService _apiService = new APIService("Certificate_Requests");
        private APIService _candidateService = new APIService("Candidates");
        private int? _id = null;
        public frmUpdateCertificateRequest(int? id = null)
        {
            InitializeComponent();
            InitializecmbStatuses();
            _id = id;
        }

        private void InitializecmbStatuses()
        {
            string[] enumElements = Enum.GetNames(typeof(Certificate_Request_Status));
            foreach (var item in enumElements)
            {
                cmbStatuses.Items.Add(item.Replace("_", " "));
            }
        }

        private async void FrmUpdateCertificateRequest_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _apiService.GetById<Model.Certificate_Request>(_id);
                var candidate = await _candidateService.GetById<Model.Candidate>(result.UserId);
                txtFirstName.Text = candidate.FirstName;
                txtLastName.Text = candidate.LastName;
                txtPurpose.Text = result.Purpose;
                // dtpDate.Value = result.Date;
                txtDate.Text = result.Date.Date.ToString("MM/dd/yyyy");
                // txtStatus.Text = result.Status;
                cmbStatuses.SelectedIndex = (int)result.Status;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var certificate_request = await _apiService.GetById<Model.Certificate_Request>(_id);
            Certificate_RequestInsert insert_request = new Certificate_RequestInsert
            {
                CertificateId = certificate_request.CertificateId,
                UserId = certificate_request.UserId,
                Purpose = certificate_request.Purpose,
                Date = certificate_request.Date.Date,
                Status = (Certificate_Request_Status)cmbStatuses.SelectedIndex
            };
            await _apiService.Update<Model.Certificate_Request>(_id, insert_request);
        }
    }
}
