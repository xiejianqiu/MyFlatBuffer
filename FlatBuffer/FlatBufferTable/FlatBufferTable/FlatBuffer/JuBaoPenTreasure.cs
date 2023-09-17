// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JuBaoPenTreasure : Table {
  public static FB_JuBaoPenTreasure GetRootAsFB_JuBaoPenTreasure(ByteBuffer _bb) { return GetRootAsFB_JuBaoPenTreasure(_bb, new FB_JuBaoPenTreasure()); }
  public static FB_JuBaoPenTreasure GetRootAsFB_JuBaoPenTreasure(ByteBuffer _bb, FB_JuBaoPenTreasure obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JuBaoPenTreasure __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Group { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Draw { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Recharge { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Cost { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetTimesList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TimesListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeightList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JuBaoPenTreasure> CreateFB_JuBaoPenTreasure(FlatBufferBuilder builder,
      int Id = 0,
      int Group = -1,
      int Draw = -1,
      int Recharge = -1,
      int Cost = -1,
      VectorOffset TimesList = default(VectorOffset),
      VectorOffset WeightList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_JuBaoPenTreasure.AddWeightList(builder, WeightList);
    FB_JuBaoPenTreasure.AddTimesList(builder, TimesList);
    FB_JuBaoPenTreasure.AddCost(builder, Cost);
    FB_JuBaoPenTreasure.AddRecharge(builder, Recharge);
    FB_JuBaoPenTreasure.AddDraw(builder, Draw);
    FB_JuBaoPenTreasure.AddGroup(builder, Group);
    FB_JuBaoPenTreasure.AddId(builder, Id);
    return FB_JuBaoPenTreasure.EndFB_JuBaoPenTreasure(builder);
  }

  public static void StartFB_JuBaoPenTreasure(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddGroup(FlatBufferBuilder builder, int Group) { builder.AddInt(1, Group, -1); }
  public static void AddDraw(FlatBufferBuilder builder, int Draw) { builder.AddInt(2, Draw, -1); }
  public static void AddRecharge(FlatBufferBuilder builder, int Recharge) { builder.AddInt(3, Recharge, -1); }
  public static void AddCost(FlatBufferBuilder builder, int Cost) { builder.AddInt(4, Cost, -1); }
  public static void AddTimesList(FlatBufferBuilder builder, VectorOffset TimesListOffset) { builder.AddOffset(5, TimesListOffset.Value, 0); }
  public static VectorOffset CreateTimesListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTimesListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset WeightListOffset) { builder.AddOffset(6, WeightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JuBaoPenTreasure> EndFB_JuBaoPenTreasure(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuBaoPenTreasure>(o);
  }
};

public sealed class FB_JuBaoPenTreasureContainer : Table {
  public static FB_JuBaoPenTreasureContainer GetRootAsFB_JuBaoPenTreasureContainer(ByteBuffer _bb) { return GetRootAsFB_JuBaoPenTreasureContainer(_bb, new FB_JuBaoPenTreasureContainer()); }
  public static FB_JuBaoPenTreasureContainer GetRootAsFB_JuBaoPenTreasureContainer(ByteBuffer _bb, FB_JuBaoPenTreasureContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JuBaoPenTreasureContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JuBaoPenTreasureContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JuBaoPenTreasure GetItems(int j) { return GetItems(new FB_JuBaoPenTreasure(), j); }
  public FB_JuBaoPenTreasure GetItems(FB_JuBaoPenTreasure obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JuBaoPenTreasureContainer> CreateFB_JuBaoPenTreasureContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JuBaoPenTreasureContainer.AddItems(builder, items);
    return FB_JuBaoPenTreasureContainer.EndFB_JuBaoPenTreasureContainer(builder);
  }

  public static void StartFB_JuBaoPenTreasureContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JuBaoPenTreasure>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JuBaoPenTreasureContainer> EndFB_JuBaoPenTreasureContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JuBaoPenTreasureContainer>(o);
  }
  public static void FinishFB_JuBaoPenTreasureContainerBuffer(FlatBufferBuilder builder, Offset<FB_JuBaoPenTreasureContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
