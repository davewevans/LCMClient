using LCMClient.Features.Orphans.Enums;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using LCMClient.Features.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Components
{
    public partial class OrphanAcademics
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Inject]
        public IAcademicRepository AcademicRepository { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        private bool showDelConfirmDialog = false;

        private ViewMode viewMode = ViewMode.List;

        private int academicIdToDelete = 0;

        private AcademicEditModel academicEdit;

        private int academicIdToEdit = 0;
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
            showDelConfirmDialog = false;
            academicEdit = new AcademicEditModel
            {
                Grade = academicRecord.Grade,
                KCPE = academicRecord.KCPE,
                KCSE = academicRecord.KCSE,
                School = academicRecord.School,
                EntryDate = academicRecord.EntryDate,
                OrphanID = academicRecord.OrphanID,
                PostKCSENotes = academicRecord.PostKCSENotes
            };
            academicIdToEdit = academicRecord.AcademicID;
            viewMode = ViewMode.Edit;
        }

        private async Task OnEditComplete(bool recordEdited)
        {
            showDelConfirmDialog = false;
            academicIdToEdit = 0;
            viewMode = ViewMode.List;
            Orphan.Academics = await AcademicRepository.GetOrphanAcademics(Orphan.OrphanID);
            StateHasChanged();
        }

        private void OnDeleteClick(int academicId)
        {
            academicIdToDelete = academicId;
            showDelConfirmDialog = true;
    }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            viewMode = ViewMode.List;
            showDelConfirmDialog = false;
            if (deleteConfirmed && academicIdToDelete != 0)
            {
                await AcademicRepository.DeleteAcademicAsync(academicIdToDelete);
                Orphan.Academics = await AcademicRepository.GetOrphanAcademics(Orphan.OrphanID);
                Toaster.Add("Record deleted.", MatToastType.Success);
                StateHasChanged();
            }
            academicIdToDelete = 0;
        }
    }
}
