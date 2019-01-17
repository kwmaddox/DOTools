using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOcean
{
    public class Droplet
    {
        public string name;
        public string size;
        public string region;
        public string image;

        public Droplet create()
        {
            return new Droplet();
        }

        public Droplet(string name, string region, string size, string image)
        {
            this.name = name;
            this.size = size;
            this.region = region;
            this.image = image;
        }

        public Droplet() : this("Placeholder Name", "nyc1", "s-1vcpu-1gb", "ubuntu-16-04-x64") {
        }
    }

    

}
