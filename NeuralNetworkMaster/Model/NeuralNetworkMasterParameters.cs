﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetworkMaster
{
    class NeuralNetworkMasterParameters
    {
        public int InputLayerSize { get; set; }
        public int HiddenLayerSize { get; set; }
        public int HiddenLayerLength { get; set; }
        public int OutputLayerSize { get; set; }
        public double Lambda { get; set; }
        public int Epoch { get; set; }
        public String DataSetUrl { get; set; }
        public String XFileName { get; set; }
        public String YFileName { get; set; }

    }   
}
    