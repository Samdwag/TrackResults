using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackResults.Model;

namespace TrackResults.Controller
{
    public class TrackMeetController
    {
        private List<TrackEvent> trackEvents;

        public TrackMeetController()
        {
            trackEvents = new List<TrackEvent>();
        }

        public bool AddOrUpdateEvent(string name, string time)
        {
            TrackEvent existing = trackEvents.Find(e => e.Name == name);
            if (existing != null)
            {
                DialogResult result = MessageBox.Show("Do you want to edit the existing event?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    existing.Name = name;
                    existing.Time = time;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                trackEvents.Add(new TrackEvent(name, time));
                return true;
            }
        }

        public List<string> GetTextOfAllEvents()
        {
            List<string> result = new List<string>();
            foreach (TrackEvent trackEvent in trackEvents)
            {
                result.Add($"Name: {trackEvent.Name}");
                result.Add($"Time: {trackEvent.Time}");
                result.Add("");
            }
            return result;
        }

        public List<string> GetEventNames()
        {
            List<string> result = new List<string>();
            foreach (TrackEvent trackEvent in trackEvents)
            {
                result.Add(trackEvent.Name);
            }
            return result;
        }

        public Dictionary<string, string> GetEventDetails(string name)
        {
            TrackEvent found = trackEvents.Find(e => e.Name == name);
            if (found == null)
            {
                return null;
            }
            else
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
                result.Add("name", found.Name);
                result.Add("time", found.Time);
                return result;
            }
        }
    }
}
