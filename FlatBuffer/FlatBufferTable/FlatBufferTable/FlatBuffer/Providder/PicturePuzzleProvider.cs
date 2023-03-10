using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PicturePuzzleProvider
    {
        private static FB_PicturePuzzleProvider _Instance;
        public static FB_PicturePuzzleProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PicturePuzzleProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/PicturePuzzle.txt";
        protected Dictionary<int, FB_PicturePuzzle> mData = new Dictionary<int, FB_PicturePuzzle>();
        private List<FB_PicturePuzzle> mListData = new List<FB_PicturePuzzle>();
        public List<FB_PicturePuzzle> ListData
        {
            get
            {
                var id = this.GetHashCode();
                if (mListData.Count <= 0)
                {
                    mListData.AddRange(mData.Values);
                }
                return mListData;
            }
        }
        public FB_PicturePuzzle GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PicturePuzzle);
        }
        public Dictionary<int, FB_PicturePuzzle> GetData()
        {
            return mData;
        }
        public void LoadFromFile(string dataPath)
        {
            this.LoadData(new ByteBuffer(File.ReadAllBytes(dataPath)));
        }
        public void LoadFromMemory(byte[] dataBytes)
        {
            this.LoadData(new ByteBuffer(dataBytes));
        }
        public void LoadData(ByteBuffer bb) {
            if (!FB_PicturePuzzleContainer.FB_PicturePuzzleContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PicturePuzzleContainer.GetRootAsFB_PicturePuzzleContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Level, item);
            }
            var id = this.GetHashCode();
        }
        public void Clear()
        {
            mData.Clear();
            mListData.Clear();
        }
    }
}
