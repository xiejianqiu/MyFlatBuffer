using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShakeCameraProvider
    {
        private static FB_ShakeCameraProvider _Instance;
        public static FB_ShakeCameraProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShakeCameraProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ShakeCamera.txt";
        protected Dictionary<int, FB_ShakeCamera> mData = new Dictionary<int, FB_ShakeCamera>();
        private List<FB_ShakeCamera> mListData = new List<FB_ShakeCamera>();
        public List<FB_ShakeCamera> ListData
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
        public FB_ShakeCamera GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShakeCamera);
        }
        public Dictionary<int, FB_ShakeCamera> GetData()
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
            if (!FB_ShakeCameraContainer.FB_ShakeCameraContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShakeCameraContainer.GetRootAsFB_ShakeCameraContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Id, item);
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
