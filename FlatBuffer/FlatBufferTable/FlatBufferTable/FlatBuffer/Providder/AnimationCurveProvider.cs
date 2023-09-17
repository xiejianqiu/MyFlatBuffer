using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AnimationCurveProvider
    {
        private static FB_AnimationCurveProvider _Instance;
        public static FB_AnimationCurveProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AnimationCurveProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/AnimationCurve.txt";
        protected Dictionary<int, FB_AnimationCurve> mData = new Dictionary<int, FB_AnimationCurve>();
        private List<FB_AnimationCurve> mListData = new List<FB_AnimationCurve>();
        public List<FB_AnimationCurve> ListData
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
        public FB_AnimationCurve GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AnimationCurve);
        }
        public Dictionary<int, FB_AnimationCurve> GetData()
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
            if (!FB_AnimationCurveContainer.FB_AnimationCurveContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AnimationCurveContainer.GetRootAsFB_AnimationCurveContainer(bb);
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
