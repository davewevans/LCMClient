using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanAcademics
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Inject]
        public IAcademicRepository AcademicRepository { get; set; }

        protected SfConfirmDeleteDialog DeleteConfirmationDialog { get; set; }

        private ViewMode viewMode = ViewMode.List;

        private int academicIdToDelete = 0;

        private AcademicEditModel academicEdit;

        private int academicIdToEdit = 0;

        private int counter = 0;

        private void OnAddClick()
        {
            viewMode = ViewMode.AddNew;
        }

        public async Task OnAddNewComplete(bool recordAdded)
        {
            viewMode = ViewMode.List;
            if (recordAdded)
            {
                Orphan.Academics = await AcademicRepository.GetOrphanAcademics(Orphan.OrphanID);
                StateHasChanged();
            }
        }

        private void OnEditClick(AcademicModel academicRecord)
        {
            Console.WriteLine($"oneditclick: {academicRecord.AcademicID}");

            academicEdit = new AcademicEditModel
            {
                Grade = academicRecord.Grade,
                KCPE = academicRecord.KCPE,
                KCSE = academicRecord.KCSE,
                School = academicRecord.School,
                EntryDate = academicRecord.EntryDate,
                OrphanID = academicRecord.OrphanID
            };
            academicIdToEdit = academicRecord.AcademicID;
            viewMode = ViewMode.Edit;
        }

        private async Task OnEditComplete(bool recordEdited)
        {
            academicIdToEdit = 0;
            viewMode = ViewMode.List;
            Orphan.Academics = await AcademicRepository.GetOrphanAcademics(Orphan.OrphanID);
            StateHasChanged();
        }

        private void OnDeleteClick(int academicId)
        {
            academicIdToDelete = academicId;
            DeleteConfirmationDialog.ShowDialog();
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            if (deleteConfirmed && academicIdToDelete != 0)
            {
                await AcademicRepository.DeleteAcademicAsync(academicIdToDelete);
                Orphan.Academics = await AcademicRepository.GetOrphanAcademics(Orphan.OrphanID);
                StateHasChanged();
            }
            academicIdToDelete = 0;
        }
    }
}
