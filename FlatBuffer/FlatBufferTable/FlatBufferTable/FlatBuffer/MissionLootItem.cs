// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionLootItem : Table {
  public static FB_MissionLootItem GetRootAsFB_MissionLootItem(ByteBuffer _bb) { return GetRootAsFB_MissionLootItem(_bb, new FB_MissionLootItem()); }
  public static FB_MissionLootItem GetRootAsFB_MissionLootItem(ByteBuffer _bb, FB_MissionLootItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionLootItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemDataID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)40; } }
  public int ItemCount { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int NpcDateID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)497; } }
  public int ItemDropRate { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)8000; } }
  public bool IsDelMissionItem { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int TYPE { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ClassID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SubClassID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsSearchClass { get { int o = __offset(22); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_MissionLootItem> CreateFB_MissionLootItem(FlatBufferBuilder builder,
      int Id = 0,
      int ItemDataID = 40,
      int ItemCount = 1,
      int NpcDateID = 497,
      int ItemDropRate = 8000,
      bool IsDelMissionItem = false,
      int TYPE = -1,
      int ClassID = 0,
      int SubClassID = 0,
      bool IsSearchClass = false) {
    builder.StartObject(10);
    FB_MissionLootItem.AddSubClassID(builder, SubClassID);
    FB_MissionLootItem.AddClassID(builder, ClassID);
    FB_MissionLootItem.AddTYPE(builder, TYPE);
    FB_MissionLootItem.AddItemDropRate(builder, ItemDropRate);
    FB_MissionLootItem.AddNpcDateID(builder, NpcDateID);
    FB_MissionLootItem.AddItemCount(builder, ItemCount);
    FB_MissionLootItem.AddItemDataID(builder, ItemDataID);
    FB_MissionLootItem.AddId(builder, Id);
    FB_MissionLootItem.AddIsSearchClass(builder, IsSearchClass);
    FB_MissionLootItem.AddIsDelMissionItem(builder, IsDelMissionItem);
    return FB_MissionLootItem.EndFB_MissionLootItem(builder);
  }

  public static void StartFB_MissionLootItem(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemDataID(FlatBufferBuilder builder, int ItemDataID) { builder.AddInt(1, ItemDataID, 40); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(2, ItemCount, 1); }
  public static void AddNpcDateID(FlatBufferBuilder builder, int NpcDateID) { builder.AddInt(3, NpcDateID, 497); }
  public static void AddItemDropRate(FlatBufferBuilder builder, int ItemDropRate) { builder.AddInt(4, ItemDropRate, 8000); }
  public static void AddIsDelMissionItem(FlatBufferBuilder builder, bool IsDelMissionItem) { builder.AddBool(5, IsDelMissionItem, false); }
  public static void AddTYPE(FlatBufferBuilder builder, int TYPE) { builder.AddInt(6, TYPE, -1); }
  public static void AddClassID(FlatBufferBuilder builder, int ClassID) { builder.AddInt(7, ClassID, 0); }
  public static void AddSubClassID(FlatBufferBuilder builder, int SubClassID) { builder.AddInt(8, SubClassID, 0); }
  public static void AddIsSearchClass(FlatBufferBuilder builder, bool IsSearchClass) { builder.AddBool(9, IsSearchClass, false); }
  public static Offset<FB_MissionLootItem> EndFB_MissionLootItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionLootItem>(o);
  }
};

public sealed class FB_MissionLootItemContainer : Table {
  public static FB_MissionLootItemContainer GetRootAsFB_MissionLootItemContainer(ByteBuffer _bb) { return GetRootAsFB_MissionLootItemContainer(_bb, new FB_MissionLootItemContainer()); }
  public static FB_MissionLootItemContainer GetRootAsFB_MissionLootItemContainer(ByteBuffer _bb, FB_MissionLootItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionLootItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionLootItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionLootItem GetItems(int j) { return GetItems(new FB_MissionLootItem(), j); }
  public FB_MissionLootItem GetItems(FB_MissionLootItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionLootItemContainer> CreateFB_MissionLootItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionLootItemContainer.AddItems(builder, items);
    return FB_MissionLootItemContainer.EndFB_MissionLootItemContainer(builder);
  }

  public static void StartFB_MissionLootItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionLootItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionLootItemContainer> EndFB_MissionLootItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionLootItemContainer>(o);
  }
  public static void FinishFB_MissionLootItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionLootItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
