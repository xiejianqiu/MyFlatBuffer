// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarCraftMap : Table {
  public static FB_StarCraftMap GetRootAsFB_StarCraftMap(ByteBuffer _bb) { return GetRootAsFB_StarCraftMap(_bb, new FB_StarCraftMap()); }
  public static FB_StarCraftMap GetRootAsFB_StarCraftMap(ByteBuffer _bb, FB_StarCraftMap obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarCraftMap __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Position { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Link { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Group { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Difficult { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Score { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GateCostNum { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetOccupyRewardList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int OccupyRewardListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarCraftMap> CreateFB_StarCraftMap(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Position = default(StringOffset),
      StringOffset Link = default(StringOffset),
      int Type = -1,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Quality = 0,
      int Group = -1,
      int Difficult = -1,
      int Score = -1,
      int GateCostNum = -1,
      VectorOffset OccupyRewardList = default(VectorOffset)) {
    builder.StartObject(12);
    FB_StarCraftMap.AddOccupyRewardList(builder, OccupyRewardList);
    FB_StarCraftMap.AddGateCostNum(builder, GateCostNum);
    FB_StarCraftMap.AddScore(builder, Score);
    FB_StarCraftMap.AddDifficult(builder, Difficult);
    FB_StarCraftMap.AddGroup(builder, Group);
    FB_StarCraftMap.AddQuality(builder, Quality);
    FB_StarCraftMap.AddIcon(builder, Icon);
    FB_StarCraftMap.AddName(builder, Name);
    FB_StarCraftMap.AddType(builder, Type);
    FB_StarCraftMap.AddLink(builder, Link);
    FB_StarCraftMap.AddPosition(builder, Position);
    FB_StarCraftMap.AddID(builder, ID);
    return FB_StarCraftMap.EndFB_StarCraftMap(builder);
  }

  public static void StartFB_StarCraftMap(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddPosition(FlatBufferBuilder builder, StringOffset PositionOffset) { builder.AddOffset(1, PositionOffset.Value, 0); }
  public static void AddLink(FlatBufferBuilder builder, StringOffset LinkOffset) { builder.AddOffset(2, LinkOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(4, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(5, IconOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(6, Quality, 0); }
  public static void AddGroup(FlatBufferBuilder builder, int Group) { builder.AddInt(7, Group, -1); }
  public static void AddDifficult(FlatBufferBuilder builder, int Difficult) { builder.AddInt(8, Difficult, -1); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(9, Score, -1); }
  public static void AddGateCostNum(FlatBufferBuilder builder, int GateCostNum) { builder.AddInt(10, GateCostNum, -1); }
  public static void AddOccupyRewardList(FlatBufferBuilder builder, VectorOffset OccupyRewardListOffset) { builder.AddOffset(11, OccupyRewardListOffset.Value, 0); }
  public static VectorOffset CreateOccupyRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOccupyRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarCraftMap> EndFB_StarCraftMap(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarCraftMap>(o);
  }
};

public sealed class FB_StarCraftMapContainer : Table {
  public static FB_StarCraftMapContainer GetRootAsFB_StarCraftMapContainer(ByteBuffer _bb) { return GetRootAsFB_StarCraftMapContainer(_bb, new FB_StarCraftMapContainer()); }
  public static FB_StarCraftMapContainer GetRootAsFB_StarCraftMapContainer(ByteBuffer _bb, FB_StarCraftMapContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarCraftMapContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarCraftMapContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarCraftMap GetItems(int j) { return GetItems(new FB_StarCraftMap(), j); }
  public FB_StarCraftMap GetItems(FB_StarCraftMap obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarCraftMapContainer> CreateFB_StarCraftMapContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarCraftMapContainer.AddItems(builder, items);
    return FB_StarCraftMapContainer.EndFB_StarCraftMapContainer(builder);
  }

  public static void StartFB_StarCraftMapContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarCraftMap>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarCraftMapContainer> EndFB_StarCraftMapContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarCraftMapContainer>(o);
  }
  public static void FinishFB_StarCraftMapContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarCraftMapContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
