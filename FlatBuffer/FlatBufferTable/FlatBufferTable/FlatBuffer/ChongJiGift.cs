// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChongJiGift : Table {
  public static FB_ChongJiGift GetRootAsFB_ChongJiGift(ByteBuffer _bb) { return GetRootAsFB_ChongJiGift(_bb, new FB_ChongJiGift()); }
  public static FB_ChongJiGift GetRootAsFB_ChongJiGift(ByteBuffer _bb, FB_ChongJiGift obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChongJiGift __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MDIndex { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RmbId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSpecialItemIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpecialItemIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSpecialItemCountList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpecialItemCountListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemCountList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemCountListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int Level { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ZhuanZhi { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChongJiGift> CreateFB_ChongJiGift(FlatBufferBuilder builder,
      int Id = 0,
      int MDIndex = -1,
      int RmbId = -1,
      VectorOffset SpecialItemIdList = default(VectorOffset),
      VectorOffset SpecialItemCountList = default(VectorOffset),
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemCountList = default(VectorOffset),
      int Level = -1,
      int ZhuanZhi = -1) {
    builder.StartObject(9);
    FB_ChongJiGift.AddZhuanZhi(builder, ZhuanZhi);
    FB_ChongJiGift.AddLevel(builder, Level);
    FB_ChongJiGift.AddItemCountList(builder, ItemCountList);
    FB_ChongJiGift.AddItemIdList(builder, ItemIdList);
    FB_ChongJiGift.AddSpecialItemCountList(builder, SpecialItemCountList);
    FB_ChongJiGift.AddSpecialItemIdList(builder, SpecialItemIdList);
    FB_ChongJiGift.AddRmbId(builder, RmbId);
    FB_ChongJiGift.AddMDIndex(builder, MDIndex);
    FB_ChongJiGift.AddId(builder, Id);
    return FB_ChongJiGift.EndFB_ChongJiGift(builder);
  }

  public static void StartFB_ChongJiGift(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMDIndex(FlatBufferBuilder builder, int MDIndex) { builder.AddInt(1, MDIndex, -1); }
  public static void AddRmbId(FlatBufferBuilder builder, int RmbId) { builder.AddInt(2, RmbId, -1); }
  public static void AddSpecialItemIdList(FlatBufferBuilder builder, VectorOffset SpecialItemIdListOffset) { builder.AddOffset(3, SpecialItemIdListOffset.Value, 0); }
  public static VectorOffset CreateSpecialItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpecialItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpecialItemCountList(FlatBufferBuilder builder, VectorOffset SpecialItemCountListOffset) { builder.AddOffset(4, SpecialItemCountListOffset.Value, 0); }
  public static VectorOffset CreateSpecialItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpecialItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(5, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemCountList(FlatBufferBuilder builder, VectorOffset ItemCountListOffset) { builder.AddOffset(6, ItemCountListOffset.Value, 0); }
  public static VectorOffset CreateItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(7, Level, -1); }
  public static void AddZhuanZhi(FlatBufferBuilder builder, int ZhuanZhi) { builder.AddInt(8, ZhuanZhi, -1); }
  public static Offset<FB_ChongJiGift> EndFB_ChongJiGift(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChongJiGift>(o);
  }
};

public sealed class FB_ChongJiGiftContainer : Table {
  public static FB_ChongJiGiftContainer GetRootAsFB_ChongJiGiftContainer(ByteBuffer _bb) { return GetRootAsFB_ChongJiGiftContainer(_bb, new FB_ChongJiGiftContainer()); }
  public static FB_ChongJiGiftContainer GetRootAsFB_ChongJiGiftContainer(ByteBuffer _bb, FB_ChongJiGiftContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChongJiGiftContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChongJiGiftContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChongJiGift GetItems(int j) { return GetItems(new FB_ChongJiGift(), j); }
  public FB_ChongJiGift GetItems(FB_ChongJiGift obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChongJiGiftContainer> CreateFB_ChongJiGiftContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChongJiGiftContainer.AddItems(builder, items);
    return FB_ChongJiGiftContainer.EndFB_ChongJiGiftContainer(builder);
  }

  public static void StartFB_ChongJiGiftContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChongJiGift>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChongJiGiftContainer> EndFB_ChongJiGiftContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChongJiGiftContainer>(o);
  }
  public static void FinishFB_ChongJiGiftContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChongJiGiftContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
