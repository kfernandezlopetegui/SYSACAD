using Entidades;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF
{
    public class PDFListaEspera
    {
        public static void CreatePdf(List<SolicitudListaEsperaDetallada> solicitudListaEsperas, Curso cursoSeleccionado)
        {
            // Crear un documento PDF

            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {

                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header()
                    .Text($"Informe de estudiantes en lista de espera de  {cursoSeleccionado.NombreConCodigo()}")
                    .SemiBold().FontSize(18).FontColor(Colors.Teal.Medium);


                    page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x =>
                    {
                        x.Spacing(20);
                        x.Item().Text("Cantidad de alumnos en lista de espera: " + solicitudListaEsperas.Count).Bold().FontSize(14).Italic();
                        x.Spacing(20);
                        int contador = 1;
                        x.Item().AlignCenter().Text("Detalle de la lista: ").Bold().FontSize(14).Italic();
                        x.Spacing(20);
                        foreach (SolicitudListaEsperaDetallada solicitudEspera in solicitudListaEsperas)
                        {
                            x.Item().Text($"Alumno N°{contador}").Bold().FontSize(14);
                            x.Item().Text($"Alumno: {solicitudEspera.NombreAlumno} {solicitudEspera.ApellidoAlumno}").FontSize(12);

                            x.Item().Text("DNI: " + solicitudEspera.IdAlumno).FontSize(12);

                            x.Item().Text("Legajo: " + solicitudEspera.LegajoAlumno).FontSize(12);
                            contador++;
                            x.Spacing(15);
                        }

                    });

                    page.Footer()
                    .AlignCenter()
                    .Text(x =>
                    {
                        x.Span("Page ");
                        x.CurrentPageNumber();
                    });


                });

            })
                .GeneratePdfAndShow();


        }

    }
}
