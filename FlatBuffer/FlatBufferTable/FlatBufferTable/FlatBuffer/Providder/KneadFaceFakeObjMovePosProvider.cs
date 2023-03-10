using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_KneadFaceFakeObjMovePosProvider
    {
        private static FB_KneadFaceFakeObjMovePosProvider _Instance;
        public static FB_KneadFaceFakeObjMovePosProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_KneadFaceFakeObjMovePosProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/KneadFaceFakeObjMovePos.txt";
        protected Dictionary<int, FB_KneadFaceFakeObjMovePos> mData = new Dictionary<int, FB_KneadFaceFakeObjMovePos>();
        private List<FB_KneadFaceFakeObjMovePos> mListData = new List<FB_KneadFaceFakeObjMovePos>();
        public List<FB_KneadFaceFakeObjMovePos> ListData
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
        public FB_KneadFaceFakeObjMovePos GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_KneadFaceFakeObjMovePos);
        }
        public Dictionary<int, FB_KneadFaceFakeObjMovePos> GetData()
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
            if (!FB_KneadFaceFakeObjMovePosContainer.FB_KneadFaceFakeObjMovePosContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_KneadFaceFakeObjMovePosContainer.GetRootAsFB_KneadFaceFakeObjMovePosContainer(bb);
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
