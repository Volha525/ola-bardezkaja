using System.IO;

namespace Trello
{
	public class FileLogger : ILogger
	{
		private StreamWriter _streamWriter;

		public FileLogger(string filePath)
		{
			_streamWriter = new StreamWriter(filePath, true);
			Log("_____Новая сессия_____" + System.DateTime.Now);
		}

		~FileLogger()
		{
			_streamWriter.Close();
		}

		public async void Log(string data)
		{
			await _streamWriter.WriteLineAsync(data);
		}
	}
}