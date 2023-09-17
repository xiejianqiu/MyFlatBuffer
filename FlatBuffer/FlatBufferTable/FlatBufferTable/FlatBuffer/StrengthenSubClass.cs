// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StrengthenSubClass : Table {
  public static FB_StrengthenSubClass GetRootAsFB_StrengthenSubClass(ByteBuffer _bb) { return GetRootAsFB_StrengthenSubClass(_bb, new FB_StrengthenSubClass()); }
  public static FB_StrengthenSubClass GetRootAsFB_StrengthenSubClass(ByteBuffer _bb, FB_StrengthenSubClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StrengthenSubClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetMissionIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MissionIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int RewardID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardCount { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FlagID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StrengthenSubClass> CreateFB_StrengthenSubClass(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset MissionIDList = default(VectorOffset),
      int RewardID = -1,
      int RewardCount = -1,
      int FlagID = -1) {
    builder.StartObject(6);
    FB_StrengthenSubClass.AddFlagID(builder, FlagID);
    FB_StrengthenSubClass.AddRewardCount(builder, RewardCount);
    FB_StrengthenSubClass.AddRewardID(builder, RewardID);
    FB_StrengthenSubClass.AddMissionIDList(builder, MissionIDList);
    FB_StrengthenSubClass.AddName(builder, Name);
    FB_StrengthenSubClass.AddID(builder, ID);
    return FB_StrengthenSubClass.EndFB_StrengthenSubClass(builder);
  }

  public static void StartFB_StrengthenSubClass(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddMissionIDList(FlatBufferBuilder builder, VectorOffset MissionIDListOffset) { builder.AddOffset(2, MissionIDListOffset.Value, 0); }
  public static VectorOffset CreateMissionIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMissionIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardID(FlatBufferBuilder builder, int RewardID) { builder.AddInt(3, RewardID, -1); }
  public static void AddRewardCount(FlatBufferBuilder builder, int RewardCount) { builder.AddInt(4, RewardCount, -1); }
  public static void AddFlagID(FlatBufferBuilder builder, int FlagID) { builder.AddInt(5, FlagID, -1); }
  public static Offset<FB_StrengthenSubClass> EndFB_StrengthenSubClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenSubClass>(o);
  }
};

public sealed class FB_StrengthenSubClassContainer : Table {
  public static FB_StrengthenSubClassContainer GetRootAsFB_StrengthenSubClassContainer(ByteBuffer _bb) { return GetRootAsFB_StrengthenSubClassContainer(_bb, new FB_StrengthenSubClassContainer()); }
  public static FB_StrengthenSubClassContainer GetRootAsFB_StrengthenSubClassContainer(ByteBuffer _bb, FB_StrengthenSubClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StrengthenSubClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StrengthenSubClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StrengthenSubClass GetItems(int j) { return GetItems(new FB_StrengthenSubClass(), j); }
  public FB_StrengthenSubClass GetItems(FB_StrengthenSubClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrengthenSubClassContainer> CreateFB_StrengthenSubClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StrengthenSubClassContainer.AddItems(builder, items);
    return FB_StrengthenSubClassContainer.EndFB_StrengthenSubClassContainer(builder);
  }

  public static void StartFB_StrengthenSubClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StrengthenSubClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrengthenSubClassContainer> EndFB_StrengthenSubClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenSubClassContainer>(o);
  }
  public static void FinishFB_StrengthenSubClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_StrengthenSubClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
