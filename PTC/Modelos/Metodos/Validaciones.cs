using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Metodos
{
    public class Validaciones
    {

        //numeros y simbolos
        public void NumerosSimbolos(object sender, KeyPressEventArgs e)
        {
            // Permitir backspace (código 8)
            if (e.KeyChar == (char)8)
            {
                return; // Permitir la tecla
            }

            // Permitir símbolos comunes
            char[] simbolosPermitidos = {'-'};

            // Bloquear letras (a-z, A-Z)
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Bloquear la tecla
            }
            // Permitir símbolos
            else if (simbolosPermitidos.Contains(e.KeyChar))
            {
                e.Handled = false; // Permitir la tecla
            }
            // Permitir números
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false; // Permitir la tecla
            }
        }

        //letras y simbolos
        public void LetrasSimbolos(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control (backspace, delete, etc.)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir espacios y símbolos
            if (char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) ||
                char.IsSymbol(e.KeyChar))
            {
                return;
            }

            // Bloquear números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento
            }
        }

        public void Letras(object sender, KeyPressEventArgs e)
        {
            bool esValido = char.IsLetter(e.KeyChar) ||
               e.KeyChar == ' ' ||
               e.KeyChar == (char)Keys.Back ||
               e.KeyChar == (char)Keys.Delete;

            if (!esValido)
            {
                e.Handled = true;
            }
        }

        public void Numeros(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o una tecla de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni un control, se consume el evento para que no se escriba
                e.Handled = true;
            }
        }

        public void Simbolos(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }

            // Alternativa: Bloquear símbolos específicos
            char[] simbolosProhibidos = { '@', '#', '$', '%', '&', '*', '!', '?' };
            if (simbolosProhibidos.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
