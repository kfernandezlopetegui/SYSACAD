using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class DescripcionCurso
    {
        public string Dias { get; set; }
        public string Horas { get; set; }
        public string Aulas { get; set; }

        public DescripcionCurso(string dias, string horas, string aulas)
        {
            Dias = dias;
            Horas = horas;
            Aulas = aulas;
        }

        public static string ObtenerDias(string descripcion)
        {
            string patronDia = @"(Lunes|Martes|Miércoles|Jueves|Viernes)";
            MatchCollection matches = Regex.Matches(descripcion, patronDia);
            string diasSeparadosPorEnter = string.Join(Environment.NewLine, matches.Cast<Match>().Select(match => match.Value));
            return diasSeparadosPorEnter;
        }

        public static string ObtenerHorarios(string descripcion)
        {
            string patronHorario = @"\b\d{1,2}:\d{2}-\d{1,2}:\d{2}\b";
            MatchCollection matches = Regex.Matches(descripcion, patronHorario);
            string horariosSeparadosPorEnter = string.Join(Environment.NewLine, matches.Cast<Match>().Select(match => match.Value));
            return horariosSeparadosPorEnter;
        }

        public static string ObtenerAula(string descripcion)
        {
            string patronAula = @"Aula: (\d+)";
            MatchCollection matchesAula = Regex.Matches(descripcion, patronAula);

            if (matchesAula.Count > 0)
            {
                var aulas = matchesAula.Cast<Match>().Select(match => match.Groups[1].Value);
                return string.Join(Environment.NewLine, aulas);
            }

            return "0";
        }
    }
}
