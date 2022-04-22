using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AswcMandatory
{
    public class TracerWorker
    {
        /// <summary>
        /// Creating a tracer object.
        /// </summary>
        private TraceSource tracer = new TraceSource("Tracer");

        /// <summary>
        /// In this section, I define my tracer switch/areas and its ´logging outputs.
        /// </summary>
        public TracerWorker()
        {
            tracer.Switch = new SourceSwitch("Jonas' Log", "All");

            TraceListener ConsolgeLog = new ConsoleTraceListener();
            tracer.Listeners.Add(ConsolgeLog);

            TraceListener xmlLog = new XmlWriterTraceListener(new StreamWriter("Tracer.xml"));
            tracer.Listeners.Add(xmlLog);
        }
    }
}
