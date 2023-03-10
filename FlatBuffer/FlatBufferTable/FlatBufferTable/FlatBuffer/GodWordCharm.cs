// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GodWordCharm : Table {
  public static FB_GodWordCharm GetRootAsFB_GodWordCharm(ByteBuffer _bb) { return GetRootAsFB_GodWordCharm(_bb, new FB_GodWordCharm()); }
  public static FB_GodWordCharm GetRootAsFB_GodWordCharm(ByteBuffer _bb, FB_GodWordCharm obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GodWordCharm __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CraftReq { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CraftNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrDictionryID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Icon { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetCraftItemList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CraftItemListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GodWordCharm> CreateFB_GodWordCharm(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int CraftReq = -1,
      int CraftNum = -1,
      int StrDictionryID = -1,
      StringOffset Icon = default(StringOffset),
      VectorOffset CraftItemList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_GodWordCharm.AddCraftItemList(builder, CraftItemList);
    FB_GodWordCharm.AddIcon(builder, Icon);
    FB_GodWordCharm.AddStrDictionryID(builder, StrDictionryID);
    FB_GodWordCharm.AddCraftNum(builder, CraftNum);
    FB_GodWordCharm.AddCraftReq(builder, CraftReq);
    FB_GodWordCharm.AddName(builder, Name);
    FB_GodWordCharm.AddId(builder, Id);
    return FB_GodWordCharm.EndFB_GodWordCharm(builder);
  }

  public static void StartFB_GodWordCharm(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddCraftReq(FlatBufferBuilder builder, int CraftReq) { builder.AddInt(2, CraftReq, -1); }
  public static void AddCraftNum(FlatBufferBuilder builder, int CraftNum) { builder.AddInt(3, CraftNum, -1); }
  public static void AddStrDictionryID(FlatBufferBuilder builder, int StrDictionryID) { builder.AddInt(4, StrDictionryID, -1); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(5, IconOffset.Value, 0); }
  public static void AddCraftItemList(FlatBufferBuilder builder, VectorOffset CraftItemListOffset) { builder.AddOffset(6, CraftItemListOffset.Value, 0); }
  public static VectorOffset CreateCraftItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCraftItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GodWordCharm> EndFB_GodWordCharm(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GodWordCharm>(o);
  }
};

public sealed class FB_GodWordCharmContainer : Table {
  public static FB_GodWordCharmContainer GetRootAsFB_GodWordCharmContainer(ByteBuffer _bb) { return GetRootAsFB_GodWordCharmContainer(_bb, new FB_GodWordCharmContainer()); }
  public static FB_GodWordCharmContainer GetRootAsFB_GodWordCharmContainer(ByteBuffer _bb, FB_GodWordCharmContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GodWordCharmContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GodWordCharmContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GodWordCharm GetItems(int j) { return GetItems(new FB_GodWordCharm(), j); }
  public FB_GodWordCharm GetItems(FB_GodWordCharm obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GodWordCharmContainer> CreateFB_GodWordCharmContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GodWordCharmContainer.AddItems(builder, items);
    return FB_GodWordCharmContainer.EndFB_GodWordCharmContainer(builder);
  }

  public static void StartFB_GodWordCharmContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GodWordCharm>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GodWordCharmContainer> EndFB_GodWordCharmContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GodWordCharmContainer>(o);
  }
  public static void FinishFB_GodWordCharmContainerBuffer(FlatBufferBuilder builder, Offset<FB_GodWordCharmContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
