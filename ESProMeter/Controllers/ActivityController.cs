using ESProMeter.Extensions;
using ESProMeter.Services;
using ESProMeter.Views.Activies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Controllers
{
    public static class ActivityController
    {

        public static void ActivityGetByBoq(this Form form,long boqId)
        {
            var container = form.AsControl<DataGridView>("dtgActivities");
            ((DataTable)container?.DataSource)?.Rows.Clear();
            AppService.GetActivityInstance.ActivityGetByBoqID(boqId, out var table);
            table.UseDataTableAsGridView(container);

        }

        public static bool ActivityCreate(this Form form, ActivityCreateFrm frm)
        {
            return AppService.GetActivityInstance.ActivityCreate(frm);

        }

    }
}
