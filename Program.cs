using PostData;

namespace MarsRoverPhotoApp
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MarsRoverPhotoForm());
        }

        // TAKE USER INPUTS AND CONVERT TO REQUIRED FORMATS FOR API
        public static void UserInfoConversion(string[] data)
        {

         /* API REQUISITES ARE:
            DATE FORMAT "YYYY-MM-DD"
            CAMERA VIEW ABREVIATIONS AS FOLLOWS... (SEE -> "roverCamDict") */

            Dictionary<string, string> roverCamDict = new Dictionary<string, string>()
            {
                { "Front Hazard Avoidance Camera", "FHAZ" },
                { "Rear Hazard Avoidance Camera", "RHAZ" },
                { "Mast Camera", "MAST" },
                { "Mars Hand Lens Imager", "MAHLI" },
                { "Mars Descent Imager", "MARDI" },
                { "Navigation Camera", "NAVCAM" }
            };

            Post newPost = new Post()
            {
                apiKey = "QUyqqGD23odmQUYfxIbAJ4K3la6Q8kaj9raT8VnO",
                earthDate = data[0],
                roverCam = roverCamDict[data[1]]
            };

            InteractWithApi(newPost.apiKey, newPost.earthDate, newPost.roverCam);
        }

        // POST USER-SELECTIONS & GET RESPONSE FROM API
        public static void InteractWithApi(object apiKey, object earthDate, object roverCam)
        {
            var imgSources = new List<string>();

            try
            {
                using (var client = new HttpClient())
                {
                    var endpoint = new Uri("https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?api_key=" +
                                            apiKey + "&earth_date=" + earthDate + "&camera=" + roverCam);
                    var result = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result.Split('"');

                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i].Contains("https"))
                        {
                            imgSources.Add(result[i]);
                        }
                    }
                }

                // CHECK IF IMAGE SOURCE ARRAY HAS BEEN POPULATED - IF NOT, DISPLAY ERROR
                if (imgSources.Count == 0)
                {
                    MessageBox.Show("Could not retreive any photos using the provided date and camera view. Try using a different date or camera view and try again.", "Unsuccessful");
                }
                else
                {
                    PhotoToDisplay(imgSources);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        // CHOOSE RANDOM IMAGE FROM LIST OF SOURCES IF MORE THAN ONE IMAGE IS AVAILABLE
        public static void PhotoToDisplay(List<string> imgURLs)
        {
            Random random = new Random();
            int camListIndex = random.Next(imgURLs.Count);
            var choosePhoto = imgURLs[camListIndex];
            selectedPhoto = choosePhoto;
        }

        // IMAGE SOURCE URL FOR USE WITH UPDATING PICTUREBOX
        public static string selectedPhoto;
 
    }
}