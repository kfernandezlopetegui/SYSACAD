using Entidades;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using QuestPDF;
using System.Reflection.PortableExecutable;
using System.Drawing;


namespace PDF
{
    public class PDFInscripcionesPorPeriodo
    {
        
        

        public static void CreatePdf(List<InscripcionInfo> inscripciones, Periodo periodo)
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
                    .Text("Informe de inscripciones en el periodo " + periodo.Inicio.ToString("dd/MM/yyyy") + " - " + periodo.Fin.ToString("dd/MM/yyyy"))
                    .SemiBold().FontSize(18).FontColor(Colors.Teal.Medium);

                    page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x =>
                    {
                        x.Spacing(20);
                        x.Item().Text("Cantidad de inscripciones: " + inscripciones.Count).Bold().FontSize(14).Italic();
                        int contador = 1;
                        foreach (InscripcionInfo inscripcion in inscripciones)
                        {
                            
                            x.Item().Text($"Inscripción N°{contador}").Bold().FontSize(14);

                            // Nombre del alumno
                            x.Item().Text("Alumno: " + inscripcion.AlumnoNombre + " " + inscripcion.AlumnoApellido).FontSize(12);

                            // DNI
                            x.Item().Text("DNI: " + inscripcion.AlumnoId).FontSize(12);

                            // Curso
                            x.Item().Text("Curso: " + inscripcion.CursoNombre).FontSize(12);

                            // Código
                            x.Item().Text("Código de curso: " + inscripcion.CursoId).FontSize(12);
                            x.Item().Text("Carrera: " + inscripcion.Carrera).FontSize(12);
                            // Fecha de inscripción
                            x.Item().Text("Fecha de inscripción: " + inscripcion.FechaInscripcion.ToString("dd/MM/yyyy")).FontSize(12);
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
