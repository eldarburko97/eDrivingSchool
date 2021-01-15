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

namespace eDrivingSchool.WinUI.TheoryTest
{
    public partial class frmTheoryTestData : Form
    {
        private APIService _theory_test_applicationsService = new APIService("TheoryTestApplications");
        private APIService _instructors_categories_candidatesService = new APIService("Instructors_Categories_Candidates");
        private APIService _candidatesService = new APIService("Candidates");
        private APIService _instructors_categoriesService = new APIService("Instructors_Categories");
        private APIService _categoriesService = new APIService("Categories");
        public frmTheoryTestData()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            TheoryTestApplicationsSearchRequest search_request = new TheoryTestApplicationsSearchRequest();
            Model.Status status;
            if (Enum.TryParse(txtSearch.Text, out status))
            {
                search_request.Status = status;
            }
            var result = await _theory_test_applicationsService.GetAll<List<Model.TheoryTestApplications>>(search_request);
            List<Instructor_Category_Candidate> list = new List<Instructor_Category_Candidate>();
            foreach (var item in result)
            {
                var instructor_category_candidate = await _instructors_categories_candidatesService.GetById<Model.Instructor_Category_Candidate>(item.Instructor_Category_CandidateId);
                var candidate = await _candidatesService.GetById<Model.Candidate>(instructor_category_candidate.UserId);
                var instructor_category = await _instructors_categoriesService.GetById<Model.Instructor_Category>(instructor_category_candidate.Instructor_CategoryId);
                var category = await _categoriesService.GetById<Model.Category>(instructor_category.CategoryId);
                instructor_category_candidate.FirstName = candidate.FirstName;
                instructor_category_candidate.LastName = candidate.LastName;
                instructor_category_candidate.Username = candidate.Username;
                instructor_category_candidate.Category = category.Name;
                list.Add(instructor_category_candidate);
            }
            dgvTheoryTestData.AutoGenerateColumns = false;
            dgvTheoryTestData.DataSource = list;
        }
    }
}
