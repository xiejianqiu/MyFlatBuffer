using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SceneShaderParamProvider
    {
        private static FB_SceneShaderParamProvider _Instance;
        public static FB_SceneShaderParamProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SceneShaderParamProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/SceneShaderParam.txt";
        protected Dictionary<int, FB_SceneShaderParam> mData = new Dictionary<int, FB_SceneShaderParam>();
        private List<FB_SceneShaderParam> mListData = new List<FB_SceneShaderParam>();
        public List<FB_SceneShaderParam> ListData
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
        public FB_SceneShaderParam GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SceneShaderParam);
        }
        public Dictionary<int, FB_SceneShaderParam> GetData()
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
            if (!FB_SceneShaderParamContainer.FB_SceneShaderParamContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SceneShaderParamContainer.GetRootAsFB_SceneShaderParamContainer(bb);
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
