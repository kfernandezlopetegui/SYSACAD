using DocumentFormat.OpenXml.Drawing.Charts;
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
    public class PDFEstadisticasPorCarrera
    {
        public static void CreatePdf(List<InscripcionInfo> inscripciones, Periodo periodo, List<EstadisticasPorCarrera> estadisticasPorCarreras)
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

                    .Text("Informe de estadisticas de inscripcion por carrera en el periodo " + periodo.Inicio.ToString("dd/MM/yyyy") + " - " + periodo.Fin.ToString("dd/MM/yyyy"))
                    .SemiBold().FontSize(18).FontColor(Colors.Teal.Medium);

                    page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x =>
                    {
                        x.Spacing(20);

                        foreach (EstadisticasPorCarrera estadisticaCarrera in estadisticasPorCarreras)
                        {
                            x.Item().Text($"El porcentaje de inscripciones a {estadisticaCarrera.Carrera} en el periodo solicitado es de {estadisticaCarrera.PorcentajeInscripciones}% con la cantidad de {estadisticaCarrera.CantidadInscripciones} inscritos").Bold().FontSize(14).Italic().FontColor(Colors.DeepPurple.Medium);
                            x.Spacing(15);
                        }
                        
                        x.Item().Text("Cantidad de inscripciones totales " + inscripciones.Count).Bold().FontSize(14).Italic();
                        x.Spacing(25);

                        if(inscripciones.Count > 0)
                        {
                            x.Item().AlignCenter().Text("Detalle de las inscripciones: ").Bold().FontSize(14).Italic();
                            x.Spacing(20);
                            int contador = 1;
                            foreach (InscripcionInfo inscripcion in inscripciones)
                            {

                                x.Item().Text($"Inscripción N°{contador}").Bold().FontSize(14);


                                x.Item().Text("Alumno: " + inscripcion.AlumnoNombre + " " + inscripcion.AlumnoApellido).FontSize(12);


                                x.Item().Text("DNI: " + inscripcion.AlumnoId).FontSize(12);


                                x.Item().Text("Curso: " + inscripcion.CursoNombre).FontSize(12);


                                x.Item().Text("Código de curso: " + inscripcion.CursoId).FontSize(12);
                                x.Item().Text("Carrera: " + inscripcion.Carrera).FontSize(12);

                                x.Item().Text("Fecha de inscripción: " + inscripcion.FechaInscripcion.ToString("dd/MM/yyyy")).FontSize(12);
                                contador++;
                                x.Spacing(15);
                            }
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
