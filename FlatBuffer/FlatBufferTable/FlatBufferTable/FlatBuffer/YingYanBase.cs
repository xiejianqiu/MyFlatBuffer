// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_YingYanBase : Table {
  public static FB_YingYanBase GetRootAsFB_YingYanBase(ByteBuffer _bb) { return GetRootAsFB_YingYanBase(_bb, new FB_YingYanBase()); }
  public static FB_YingYanBase GetRootAsFB_YingYanBase(ByteBuffer _bb, FB_YingYanBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_YingYanBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Time { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int QuestCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetNumberList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int NumberListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int Exp { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BindMoney { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PigCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_YingYanBase> CreateFB_YingYanBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Time = -1,
      int QuestCount = -1,
      VectorOffset NumberList = default(VectorOffset),
      int Exp = -1,
      int BindMoney = -1,
      int PigCount = -1) {
    builder.StartObject(8);
    FB_YingYanBase.AddPigCount(builder, PigCount);
    FB_YingYanBase.AddBindMoney(builder, BindMoney);
    FB_YingYanBase.AddExp(builder, Exp);
    FB_YingYanBase.AddNumberList(builder, NumberList);
    FB_YingYanBase.AddQuestCount(builder, QuestCount);
    FB_YingYanBase.AddTime(builder, Time);
    FB_YingYanBase.AddName(builder, Name);
    FB_YingYanBase.AddID(builder, ID);
    return FB_YingYanBase.EndFB_YingYanBase(builder);
  }

  public static void StartFB_YingYanBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTime(FlatBufferBuilder builder, int Time) { builder.AddInt(2, Time, -1); }
  public static void AddQuestCount(FlatBufferBuilder builder, int QuestCount) { builder.AddInt(3, QuestCount, -1); }
  public static void AddNumberList(FlatBufferBuilder builder, VectorOffset NumberListOffset) { builder.AddOffset(4, NumberListOffset.Value, 0); }
  public static VectorOffset CreateNumberListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartNumberListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(5, Exp, -1); }
  public static void AddBindMoney(FlatBufferBuilder builder, int BindMoney) { builder.AddInt(6, BindMoney, -1); }
  public static void AddPigCount(FlatBufferBuilder builder, int PigCount) { builder.AddInt(7, PigCount, -1); }
  public static Offset<FB_YingYanBase> EndFB_YingYanBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YingYanBase>(o);
  }
};

public sealed class FB_YingYanBaseContainer : Table {
  public static FB_YingYanBaseContainer GetRootAsFB_YingYanBaseContainer(ByteBuffer _bb) { return GetRootAsFB_YingYanBaseContainer(_bb, new FB_YingYanBaseContainer()); }
  public static FB_YingYanBaseContainer GetRootAsFB_YingYanBaseContainer(ByteBuffer _bb, FB_YingYanBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_YingYanBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_YingYanBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_YingYanBase GetItems(int j) { return GetItems(new FB_YingYanBase(), j); }
  public FB_YingYanBase GetItems(FB_YingYanBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_YingYanBaseContainer> CreateFB_YingYanBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_YingYanBaseContainer.AddItems(builder, items);
    return FB_YingYanBaseContainer.EndFB_YingYanBaseContainer(builder);
  }

  public static void StartFB_YingYanBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_YingYanBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_YingYanBaseContainer> EndFB_YingYanBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YingYanBaseContainer>(o);
  }
  public static void FinishFB_YingYanBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_YingYanBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
