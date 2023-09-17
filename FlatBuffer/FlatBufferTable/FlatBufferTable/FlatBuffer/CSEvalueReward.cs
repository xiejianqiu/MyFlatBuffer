// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CSEvalueReward : Table {
  public static FB_CSEvalueReward GetRootAsFB_CSEvalueReward(ByteBuffer _bb) { return GetRootAsFB_CSEvalueReward(_bb, new FB_CSEvalueReward()); }
  public static FB_CSEvalueReward GetRootAsFB_CSEvalueReward(ByteBuffer _bb, FB_CSEvalueReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CSEvalueReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDropIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DropIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetKExpIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int KExpIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int ExpRewardId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CSEvalueReward> CreateFB_CSEvalueReward(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset DropIDList = default(VectorOffset),
      VectorOffset kExpIDList = default(VectorOffset),
      int ExpRewardId = -1) {
    builder.StartObject(5);
    FB_CSEvalueReward.AddExpRewardId(builder, ExpRewardId);
    FB_CSEvalueReward.AddKExpIDList(builder, kExpIDList);
    FB_CSEvalueReward.AddDropIDList(builder, DropIDList);
    FB_CSEvalueReward.AddItemIDList(builder, ItemIDList);
    FB_CSEvalueReward.AddId(builder, Id);
    return FB_CSEvalueReward.EndFB_CSEvalueReward(builder);
  }

  public static void StartFB_CSEvalueReward(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(1, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDropIDList(FlatBufferBuilder builder, VectorOffset DropIDListOffset) { builder.AddOffset(2, DropIDListOffset.Value, 0); }
  public static VectorOffset CreateDropIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDropIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddKExpIDList(FlatBufferBuilder builder, VectorOffset kExpIDListOffset) { builder.AddOffset(3, kExpIDListOffset.Value, 0); }
  public static VectorOffset CreateKExpIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartKExpIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExpRewardId(FlatBufferBuilder builder, int ExpRewardId) { builder.AddInt(4, ExpRewardId, -1); }
  public static Offset<FB_CSEvalueReward> EndFB_CSEvalueReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CSEvalueReward>(o);
  }
};

public sealed class FB_CSEvalueRewardContainer : Table {
  public static FB_CSEvalueRewardContainer GetRootAsFB_CSEvalueRewardContainer(ByteBuffer _bb) { return GetRootAsFB_CSEvalueRewardContainer(_bb, new FB_CSEvalueRewardContainer()); }
  public static FB_CSEvalueRewardContainer GetRootAsFB_CSEvalueRewardContainer(ByteBuffer _bb, FB_CSEvalueRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CSEvalueRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CSEvalueRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CSEvalueReward GetItems(int j) { return GetItems(new FB_CSEvalueReward(), j); }
  public FB_CSEvalueReward GetItems(FB_CSEvalueReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CSEvalueRewardContainer> CreateFB_CSEvalueRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CSEvalueRewardContainer.AddItems(builder, items);
    return FB_CSEvalueRewardContainer.EndFB_CSEvalueRewardContainer(builder);
  }

  public static void StartFB_CSEvalueRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CSEvalueReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CSEvalueRewardContainer> EndFB_CSEvalueRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CSEvalueRewardContainer>(o);
  }
  public static void FinishFB_CSEvalueRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_CSEvalueRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
