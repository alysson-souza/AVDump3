﻿using AVDump3Lib.Processing.BlockConsumers.Ogg;
using AVDump3Lib.Processing.BlockConsumers.Ogg.BitStreams;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AVDump3Lib.Processing.BlockConsumers.Ogg {
	public class OggFile {
		public long FileSize { get; private set; }
		public long Overhead { get; private set; }
		public IEnumerable<OGGBitStream> Bitstreams { get { return bitStreams.Values; } }

		private Dictionary<uint, OGGBitStream> bitStreams = new Dictionary<uint, OGGBitStream>();



        public void ProcessOggPage(ref OggPage page) {
            Overhead += 27 + page.SegmentCount;

            OGGBitStream bitStream = null;
            if(bitStreams.TryGetValue(page.StreamId, out bitStream)) {
                bitStream.ProcessPage(ref page);

            } else if(page.Flags.HasFlag(PageFlags.Header)) {
                bitStream = OGGBitStream.ProcessBeginPage(ref page);
                bitStreams.Add(bitStream.Id, bitStream);

            } else {
                Overhead += page.Data.Length;
            }
        }
    }
}