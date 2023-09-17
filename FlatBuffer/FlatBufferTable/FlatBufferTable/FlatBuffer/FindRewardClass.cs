// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_FindRewardClass : Table {
  public static FB_FindRewardClass GetRootAsFB_FindRewardClass(ByteBuffer _bb) { return GetRootAsFB_FindRewardClass(_bb, new FB_FindRewardClass()); }
  public static FB_FindRewardClass GetRootAsFB_FindRewardClass(ByteBuffer _bb, FB_FindRewardClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_FindRewardClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BaseID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinLvl { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLvl { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CSLvl { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowExp { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetLowItemIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LowItemIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLowItemCountList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LowItemCountListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int HighExp { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetHighItemIDList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighItemIDListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHighItemCountList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighItemCountListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int ChangeJobLimit { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_FindRewardClass> CreateFB_FindRewardClass(FlatBufferBuilder builder,
      int ID = 0,
      int BaseID = -1,
      int MinLvl = -1,
      int MaxLvl = -1,
      int CSLvl = -1,
      int LowExp = -1,
      VectorOffset LowItemIDList = default(VectorOffset),
      VectorOffset LowItemCountList = default(VectorOffset),
      int HighExp = -1,
      VectorOffset HighItemIDList = default(VectorOffset),
      VectorOffset HighItemCountList = default(VectorOffset),
      int ChangeJobLimit = -1) {
    builder.StartObject(12);
    FB_FindRewardClass.AddChangeJobLimit(builder, ChangeJobLimit);
    FB_FindRewardClass.AddHighItemCountList(builder, HighItemCountList);
    FB_FindRewardClass.AddHighItemIDList(builder, HighItemIDList);
    FB_FindRewardClass.AddHighExp(builder, HighExp);
    FB_FindRewardClass.AddLowItemCountList(builder, LowItemCountList);
    FB_FindRewardClass.AddLowItemIDList(builder, LowItemIDList);
    FB_FindRewardClass.AddLowExp(builder, LowExp);
    FB_FindRewardClass.AddCSLvl(builder, CSLvl);
    FB_FindRewardClass.AddMaxLvl(builder, MaxLvl);
    FB_FindRewardClass.AddMinLvl(builder, MinLvl);
    FB_FindRewardClass.AddBaseID(builder, BaseID);
    FB_FindRewardClass.AddID(builder, ID);
    return FB_FindRewardClass.EndFB_FindRewardClass(builder);
  }

  public static void StartFB_FindRewardClass(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddBaseID(FlatBufferBuilder builder, int BaseID) { builder.AddInt(1, BaseID, -1); }
  public static void AddMinLvl(FlatBufferBuilder builder, int MinLvl) { builder.AddInt(2, MinLvl, -1); }
  public static void AddMaxLvl(FlatBufferBuilder builder, int MaxLvl) { builder.AddInt(3, MaxLvl, -1); }
  public static void AddCSLvl(FlatBufferBuilder builder, int CSLvl) { builder.AddInt(4, CSLvl, -1); }
  public static void AddLowExp(FlatBufferBuilder builder, int LowExp) { builder.AddInt(5, LowExp, -1); }
  public static void AddLowItemIDList(FlatBufferBuilder builder, VectorOffset LowItemIDListOffset) { builder.AddOffset(6, LowItemIDListOffset.Value, 0); }
  public static VectorOffset CreateLowItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLowItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLowItemCountList(FlatBufferBuilder builder, VectorOffset LowItemCountListOffset) { builder.AddOffset(7, LowItemCountListOffset.Value, 0); }
  public static VectorOffset CreateLowItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLowItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighExp(FlatBufferBuilder builder, int HighExp) { builder.AddInt(8, HighExp, -1); }
  public static void AddHighItemIDList(FlatBufferBuilder builder, VectorOffset HighItemIDListOffset) { builder.AddOffset(9, HighItemIDListOffset.Value, 0); }
  public static VectorOffset CreateHighItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighItemCountList(FlatBufferBuilder builder, VectorOffset HighItemCountListOffset) { builder.AddOffset(10, HighItemCountListOffset.Value, 0); }
  public static VectorOffset CreateHighItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChangeJobLimit(FlatBufferBuilder builder, int ChangeJobLimit) { builder.AddInt(11, ChangeJobLimit, -1); }
  public static Offset<FB_FindRewardClass> EndFB_FindRewardClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FindRewardClass>(o);
  }
};

public sealed class FB_FindRewardClassContainer : Table {
  public static FB_FindRewardClassContainer GetRootAsFB_FindRewardClassContainer(ByteBuffer _bb) { return GetRootAsFB_FindRewardClassContainer(_bb, new FB_FindRewardClassContainer()); }
  public static FB_FindRewardClassContainer GetRootAsFB_FindRewardClassContainer(ByteBuffer _bb, FB_FindRewardClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_FindRewardClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_FindRewardClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_FindRewardClass GetItems(int j) { return GetItems(new FB_FindRewardClass(), j); }
  public FB_FindRewardClass GetItems(FB_FindRewardClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FindRewardClassContainer> CreateFB_FindRewardClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_FindRewardClassContainer.AddItems(builder, items);
    return FB_FindRewardClassContainer.EndFB_FindRewardClassContainer(builder);
  }

  public static void StartFB_FindRewardClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_FindRewardClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FindRewardClassContainer> EndFB_FindRewardClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FindRewardClassContainer>(o);
  }
  public static void FinishFB_FindRewardClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_FindRewardClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
