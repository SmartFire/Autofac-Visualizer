﻿using System;
using System.Collections.Generic;

namespace Graves.Visualizers.Autofac.Data.Structures {

	[Serializable]
	public struct ActivationData {
		public Type Built { get; set; }
		public IEnumerable<ActivationData> Buildees { get; set; }
	}
}