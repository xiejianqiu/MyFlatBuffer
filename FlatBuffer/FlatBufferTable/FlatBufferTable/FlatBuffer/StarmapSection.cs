// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarmapSection : Table {
  public static FB_StarmapSection GetRootAsFB_StarmapSection(ByteBuffer _bb) { return GetRootAsFB_StarmapSection(_bb, new FB_StarmapSection()); }
  public static FB_StarmapSection GetRootAsFB_StarmapSection(ByteBuffer _bb, FB_StarmapSection obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarmapSection __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string OrderName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnlockLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string IconName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MaxStarmap { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SortID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetStarmapList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StarmapListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int MainGridType { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string MainGridName { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_StarmapSection> CreateFB_StarmapSection(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset OrderName = default(StringOffset),
      StringOffset Name = default(StringOffset),
      int UnlockLevel = -1,
      StringOffset IconName = default(StringOffset),
      int MaxStarmap = -1,
      int SortID = -1,
      VectorOffset StarmapList = default(VectorOffset),
      int MainGridType = -1,
      StringOffset MainGridName = default(StringOffset)) {
    builder.StartObject(10);
    FB_StarmapSection.AddMainGridName(builder, MainGridName);
    FB_StarmapSection.AddMainGridType(builder, MainGridType);
    FB_StarmapSection.AddStarmapList(builder, StarmapList);
    FB_StarmapSection.AddSortID(builder, SortID);
    FB_StarmapSection.AddMaxStarmap(builder, MaxStarmap);
    FB_StarmapSection.AddIconName(builder, IconName);
    FB_StarmapSection.AddUnlockLevel(builder, UnlockLevel);
    FB_StarmapSection.AddName(builder, Name);
    FB_StarmapSection.AddOrderName(builder, OrderName);
    FB_StarmapSection.AddID(builder, ID);
    return FB_StarmapSection.EndFB_StarmapSection(builder);
  }

  public static void StartFB_StarmapSection(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddOrderName(FlatBufferBuilder builder, StringOffset OrderNameOffset) { builder.AddOffset(1, OrderNameOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddUnlockLevel(FlatBufferBuilder builder, int UnlockLevel) { builder.AddInt(3, UnlockLevel, -1); }
  public static void AddIconName(FlatBufferBuilder builder, StringOffset IconNameOffset) { builder.AddOffset(4, IconNameOffset.Value, 0); }
  public static void AddMaxStarmap(FlatBufferBuilder builder, int MaxStarmap) { builder.AddInt(5, MaxStarmap, -1); }
  public static void AddSortID(FlatBufferBuilder builder, int SortID) { builder.AddInt(6, SortID, -1); }
  public static void AddStarmapList(FlatBufferBuilder builder, VectorOffset StarmapListOffset) { builder.AddOffset(7, StarmapListOffset.Value, 0); }
  public static VectorOffset CreateStarmapListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStarmapListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMainGridType(FlatBufferBuilder builder, int MainGridType) { builder.AddInt(8, MainGridType, -1); }
  public static void AddMainGridName(FlatBufferBuilder builder, StringOffset MainGridNameOffset) { builder.AddOffset(9, MainGridNameOffset.Value, 0); }
  public static Offset<FB_StarmapSection> EndFB_StarmapSection(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarmapSection>(o);
  }
};

public sealed class FB_StarmapSectionContainer : Table {
  public static FB_StarmapSectionContainer GetRootAsFB_StarmapSectionContainer(ByteBuffer _bb) { return GetRootAsFB_StarmapSectionContainer(_bb, new FB_StarmapSectionContainer()); }
  public static FB_StarmapSectionContainer GetRootAsFB_StarmapSectionContainer(ByteBuffer _bb, FB_StarmapSectionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarmapSectionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarmapSectionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarmapSection GetItems(int j) { return GetItems(new FB_StarmapSection(), j); }
  public FB_StarmapSection GetItems(FB_StarmapSection obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarmapSectionContainer> CreateFB_StarmapSectionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarmapSectionContainer.AddItems(builder, items);
    return FB_StarmapSectionContainer.EndFB_StarmapSectionContainer(builder);
  }

  public static void StartFB_StarmapSectionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarmapSection>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarmapSectionContainer> EndFB_StarmapSectionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarmapSectionContainer>(o);
  }
  public static void FinishFB_StarmapSectionContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarmapSectionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
