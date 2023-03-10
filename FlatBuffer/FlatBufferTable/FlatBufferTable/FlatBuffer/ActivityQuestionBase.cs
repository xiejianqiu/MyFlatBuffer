// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityQuestionBase : Table {
  public static FB_ActivityQuestionBase GetRootAsFB_ActivityQuestionBase(ByteBuffer _bb) { return GetRootAsFB_ActivityQuestionBase(_bb, new FB_ActivityQuestionBase()); }
  public static FB_ActivityQuestionBase GetRootAsFB_ActivityQuestionBase(ByteBuffer _bb, FB_ActivityQuestionBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityQuestionBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int QuestionDic { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAnswerList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AnswerListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityQuestionBase> CreateFB_ActivityQuestionBase(FlatBufferBuilder builder,
      int ID = 0,
      int QuestionDic = -1,
      VectorOffset AnswerList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_ActivityQuestionBase.AddAnswerList(builder, AnswerList);
    FB_ActivityQuestionBase.AddQuestionDic(builder, QuestionDic);
    FB_ActivityQuestionBase.AddID(builder, ID);
    return FB_ActivityQuestionBase.EndFB_ActivityQuestionBase(builder);
  }

  public static void StartFB_ActivityQuestionBase(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddQuestionDic(FlatBufferBuilder builder, int QuestionDic) { builder.AddInt(1, QuestionDic, -1); }
  public static void AddAnswerList(FlatBufferBuilder builder, VectorOffset AnswerListOffset) { builder.AddOffset(2, AnswerListOffset.Value, 0); }
  public static VectorOffset CreateAnswerListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAnswerListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityQuestionBase> EndFB_ActivityQuestionBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityQuestionBase>(o);
  }
};

public sealed class FB_ActivityQuestionBaseContainer : Table {
  public static FB_ActivityQuestionBaseContainer GetRootAsFB_ActivityQuestionBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityQuestionBaseContainer(_bb, new FB_ActivityQuestionBaseContainer()); }
  public static FB_ActivityQuestionBaseContainer GetRootAsFB_ActivityQuestionBaseContainer(ByteBuffer _bb, FB_ActivityQuestionBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityQuestionBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityQuestionBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityQuestionBase GetItems(int j) { return GetItems(new FB_ActivityQuestionBase(), j); }
  public FB_ActivityQuestionBase GetItems(FB_ActivityQuestionBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityQuestionBaseContainer> CreateFB_ActivityQuestionBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityQuestionBaseContainer.AddItems(builder, items);
    return FB_ActivityQuestionBaseContainer.EndFB_ActivityQuestionBaseContainer(builder);
  }

  public static void StartFB_ActivityQuestionBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityQuestionBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityQuestionBaseContainer> EndFB_ActivityQuestionBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityQuestionBaseContainer>(o);
  }
  public static void FinishFB_ActivityQuestionBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityQuestionBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
