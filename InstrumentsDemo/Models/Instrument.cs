
// Musical instruments, provide form where they can put in an instrument
// validate that the year <= currentyear validate that price is > 0
// dropdown type - Piano, Acoustic Guitar, electric guitar,synth,trumpet 
// color will be a dropdown: black,white,green,red,blue
// if validation comes back wrong go back to form with error message, otherwise go to ty page showing the instrumetn that was entered 

// modle string 
// color string 
// year int
// price decimal
// type string

namespace InstrumentsDemo.Models
{
    public class Instrument
    {
        public string model { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }
        public string type { get; set; }

    }
}
