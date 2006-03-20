//
// System.ServiceProcess.ServiceController 
//
// Author: Marek Safar (marek.safar@seznam.cz)
//
// (C) 2005, Marek Safar

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.ComponentModel;

namespace System.ServiceProcess
{
	public class ServiceController : Component
	{

		[MonoTODO]
		public ServiceController () {}
		public ServiceController (string name) {}
		public ServiceController (string name, string machineName) {}

		[MonoTODO]
		public ServiceControllerStatus Status {
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public string ServiceName {
			get	{
				throw new NotImplementedException ();
			}
			set	{
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public static ServiceController[] GetServices ()
		{
			throw new NotImplementedException ();
		}
		
		[MonoTODO]
		public void Stop () {
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public void WaitForStatus (ServiceControllerStatus desiredStatus){
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public void WaitForStatus (ServiceControllerStatus desiredStatus, TimeSpan timeout)
		{
			throw new NotImplementedException ();
		}
	

	}
}
