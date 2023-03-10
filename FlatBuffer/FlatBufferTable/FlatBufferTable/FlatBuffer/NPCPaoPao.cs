// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_NPCPaoPao : Table {
  public static FB_NPCPaoPao GetRootAsFB_NPCPaoPao(ByteBuffer _bb) { return GetRootAsFB_NPCPaoPao(_bb, new FB_NPCPaoPao()); }
  public static FB_NPCPaoPao GetRootAsFB_NPCPaoPao(ByteBuffer _bb, FB_NPCPaoPao obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_NPCPaoPao __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetStrDescIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StrDescIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public float LeftTime { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_NPCPaoPao> CreateFB_NPCPaoPao(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset StrDescIdList = default(VectorOffset),
      float LeftTime = 0) {
    builder.StartObject(3);
    FB_NPCPaoPao.AddLeftTime(builder, LeftTime);
    FB_NPCPaoPao.AddStrDescIdList(builder, StrDescIdList);
    FB_NPCPaoPao.AddId(builder, Id);
    return FB_NPCPaoPao.EndFB_NPCPaoPao(builder);
  }

  public static void StartFB_NPCPaoPao(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStrDescIdList(FlatBufferBuilder builder, VectorOffset StrDescIdListOffset) { builder.AddOffset(1, StrDescIdListOffset.Value, 0); }
  public static VectorOffset CreateStrDescIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStrDescIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLeftTime(FlatBufferBuilder builder, float LeftTime) { builder.AddFloat(2, LeftTime, 0); }
  public static Offset<FB_NPCPaoPao> EndFB_NPCPaoPao(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_NPCPaoPao>(o);
  }
};

public sealed class FB_NPCPaoPaoContainer : Table {
  public static FB_NPCPaoPaoContainer GetRootAsFB_NPCPaoPaoContainer(ByteBuffer _bb) { return GetRootAsFB_NPCPaoPaoContainer(_bb, new FB_NPCPaoPaoContainer()); }
  public static FB_NPCPaoPaoContainer GetRootAsFB_NPCPaoPaoContainer(ByteBuffer _bb, FB_NPCPaoPaoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_NPCPaoPaoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_NPCPaoPaoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_NPCPaoPao GetItems(int j) { return GetItems(new FB_NPCPaoPao(), j); }
  public FB_NPCPaoPao GetItems(FB_NPCPaoPao obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_NPCPaoPaoContainer> CreateFB_NPCPaoPaoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_NPCPaoPaoContainer.AddItems(builder, items);
    return FB_NPCPaoPaoContainer.EndFB_NPCPaoPaoContainer(builder);
  }

  public static void StartFB_NPCPaoPaoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_NPCPaoPao>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_NPCPaoPaoContainer> EndFB_NPCPaoPaoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_NPCPaoPaoContainer>(o);
  }
  public static void FinishFB_NPCPaoPaoContainerBuffer(FlatBufferBuilder builder, Offset<FB_NPCPaoPaoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
