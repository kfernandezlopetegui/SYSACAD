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
    public class PDFCursoConEstudiantes
    {
        public static void CreatePdf(List<AlumnoInforme> listaAlumnos, Curso cursoSeleccionado)
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
                    .Text($"Informe de estudiantes inscritos en {cursoSeleccionado.NombreConCodigo()}")
                    .SemiBold().FontSize(18).FontColor(Colors.Teal.Medium);

                    
                    page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x =>
                    {
                        x.Spacing(20);
                        x.Item().Text("Cantidad de alumnos inscritos: " + listaAlumnos.Count).Bold().FontSize(14).Italic();
                        int contador = 1;
                        foreach (AlumnoInforme alumno in listaAlumnos)
                        {
                            x.Item().Text($"Alumno N°{contador}").Bold().FontSize(14);
                            x.Item().Text($"Alumno: {alumno.Nombre} {alumno.Apellido}").FontSize(12);

                            x.Item().Text("DNI: " + alumno.Dni).FontSize(12);

                            x.Item().Text("Correo Electronico: " + alumno.Email).FontSize(12);
                            contador++;
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
