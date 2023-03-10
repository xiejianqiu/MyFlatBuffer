using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_QianKunDuoBaoGetIntegralProvider
    {
        private static FB_QianKunDuoBaoGetIntegralProvider _Instance;
        public static FB_QianKunDuoBaoGetIntegralProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_QianKunDuoBaoGetIntegralProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/QianKunDuoBaoGetIntegral.txt";
        protected Dictionary<int, FB_QianKunDuoBaoGetIntegral> mData = new Dictionary<int, FB_QianKunDuoBaoGetIntegral>();
        private List<FB_QianKunDuoBaoGetIntegral> mListData = new List<FB_QianKunDuoBaoGetIntegral>();
        public List<FB_QianKunDuoBaoGetIntegral> ListData
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
        public FB_QianKunDuoBaoGetIntegral GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_QianKunDuoBaoGetIntegral);
        }
        public Dictionary<int, FB_QianKunDuoBaoGetIntegral> GetData()
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
            if (!FB_QianKunDuoBaoGetIntegralContainer.FB_QianKunDuoBaoGetIntegralContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_QianKunDuoBaoGetIntegralContainer.GetRootAsFB_QianKunDuoBaoGetIntegralContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ID, item);
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
