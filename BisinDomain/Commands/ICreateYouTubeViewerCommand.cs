using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BisinIPT101Solution.BisinDomain.Models;

namespace BisinIPT101Solution.BisinDomain.Commands
{
    public interface ICreateYouTubeViewerCommand
    {
        Task Execute(YouTubeViewer youTubeViewer);
    }
}
