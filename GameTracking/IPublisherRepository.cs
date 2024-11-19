using GameTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTracking
{
	public interface IPublisherRepository
	{
		Publisher FetchPublisher(int publisherID);

		Publisher GetPublisher(string name);
	}
}
